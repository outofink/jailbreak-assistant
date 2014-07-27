import urllib2, json, collections
json_url="http://api.ios.icj.me/firmwares.json/condensed"
raw_json = urllib2.urlopen(urllib2.Request(json_url)).read()
decoded = json.loads(raw_json)

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
"iPod4,1":"iPod Touch 4G",
"iPod5,1":"iPod Touch 5G"
}

ordered_devices = collections.OrderedDict(sorted(devices.items(), key=lambda t: t[1]))

def getVersionLine(device):
	single = []
	for numb in range(len(decoded["devices"][device]["firmwares"])):
		version=decoded["devices"][device]["firmwares"][numb]["version"]
		if int(version[0]) >= 6:
			single.append(version)
	single.sort()
	return '<device name="%s" version="%s"/>\n' % (devices[device], ','.join(single))

final= "<root>\n"
for device in ordered_devices:
	final += getVersionLine(device)
final += "</root>"

ios_file=open("Jailbreak Assistant/Resources/ios.xml", "w")
ios_file.write(final)
ios_file.close()