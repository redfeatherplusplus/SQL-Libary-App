# Author: Daren Cheng
# Class: CS 6350
# Date: 9/27/2016
# 
# Desc: Generates book.csv from the normalized books.csv

# defined constants
derived_table_name = "book.csv"
ISBN10 = 0
ISBN13 = 1
Title = 2
Author = 3
Cover = 4
Publisher = 5
Pages = 6

def main(filepath): 
	# read lines from the file
	file = open(filepath, "r")
	lines = file.readlines()
	file.close()
	
	# derive the appropriate tuples from each line
	filepath = "\\".join(filepath.split("\\")[:-1]) + "\\" + derived_table_name
	file = open(filepath, "w")
	
	column_headers = "	".join(["Isbn", "Title", "Cover", "Publisher", "Pages"]) + "\n"
	file.write(column_headers)
	
	for line in lines[1:]:
		write_derived_tuples(file, line)
	file.close()

def write_derived_tuples(file, line):
	books_tuple = line.split("	")
	book_tuple = "	".join([books_tuple[ISBN13][:-3], books_tuple[Title], books_tuple[Cover], books_tuple[Publisher], books_tuple[Pages][:-1]]) + "\n"
	
	# note: I use [:-3] on ISBN13 since I accidentally 
	# converted the string to a numerical in Excel.
	# Similarly the [:-1] on Pages is to ignore its newline.
	
	file.write(book_tuple)

if __name__ == '__main__':
	main("C:\\Users\\Cheng\\Downloads\\books_03.csv")