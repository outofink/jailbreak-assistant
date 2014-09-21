###
# iosgetter.py
#
# a python script that uses Just a Penguin's iOS firmware API
# to constuct a .xml of all the latest firmwares for iOS devices
#
###

import urllib2, json, collections
firmware_url="http://api.ios.icj.me/firmwares.json/condensed"
raw_json = urllib2.urlopen(urllib2.Request(firmware_url)).read()
decoded_json = json.loads(raw_json)

devices = { 
"iPad2,1":"iPad 2",
"iPad3,1":"iPad 3",
"iPad3,4":"iPad 4",
"iPad4,1":"iPad Air",
"iPad2,5":"iPad Mini",
"iPad4,5":"iPad Mini 2",
"iPhone2,1":"iPhone 3GS",
"iPhone3,1":"iPhone 4",
"iPhone4,1":"iPhone 4S",
"iPhone5,1":"iPhone 5",
"iPhone5,3":"iPhone 5C",
"iPhone6,1":"iPhone 5S",
"iPhone7,1":"iPhone 6+",
"iPhone7,2":"iPhone 6",
"iPod4,1":"iPod Touch 4G",
"iPod5,1":"iPod Touch 5G"
}

ordered_devices = collections.OrderedDict(sorted(devices.items(), key=lambda t: t[1]))

def getVersionLine(device):
	firmwares = []
	for index in range(len(decoded_json["devices"][device]["firmwares"])):
		version = decoded_json["devices"][device]["firmwares"][index]["version"]
		if int(version[0]) >= 6:
			firmwares.append(version)
	firmwares.sort()
	return '<device name="%s" version="%s"/>\n' % (devices[device], ','.join(firmwares))

final = "<root>\n"
for device in ordered_devices:
	final += getVersionLine(device)
final += "</root>"

ios_file = open("Jailbreak Assistant/Resources/ios.xml", "w")
ios_file.write(final)
ios_file.close()