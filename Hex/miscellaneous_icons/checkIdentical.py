import filecmp

folderpath = 'D:/miscellaneous_icons/'

for x in range(1, 108):
	for y in range(x + 1, 108):
		filename1 = str(x) + '.txt'
		filename2 = str(y) + '.txt'
		
		filepath1 = folderpath + filename1
		filepath2 = folderpath + filename2
		
		isIdentical = filecmp.cmp(filepath1, filepath2)
		
		if isIdentical == True:
			if x != y:
				print("Identical: " + filename1 + " and " + filename2 + "\n")