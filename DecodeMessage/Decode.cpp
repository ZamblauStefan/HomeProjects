#include <iostream>
#include <fstream>
#include <string>
#include <ctype.h>
using namespace std;
#define max 305


string decode(string message_file)
{
	//the final message
	string decoded_message = "";

	//the string of characters from each line
	string line_read = "";

	//the list of words in sorted order
	string ordered_words[max];

	//a variable to keep track in wich row we are
	int rows = 1;

	//we open the .txt file as we already know the name we do not need an input
	ifstream MyReadFile("coding_qual_input.txt");

	/* we read each line and store it in a string, then we check each character 
	*  of the string and if it is a digit we store it in a string that we will 
	*  later convert into an integer, if the character we check is a letter
	*  we store it into a string variable and later on store it into an
	*  ordered array of strings at the position indicated by digits
	*/

	while (getline(MyReadFile, line_read)) {

		int word_position = 0;
		string position = "";
		string word = "";



		//here we do the line splitting into the number and the word
		for (int i = 0; i < line_read.size(); i++)
		{
			if (isdigit(line_read[i]))
			{
				position = position + line_read[i];
			}
			else if(isalpha(line_read[i]))
			{
				word = word + line_read[i];
			}
		}

		word_position = stoi(position);
		ordered_words[word_position] = word;
		rows++;	
	}

	int step=1;

	//here we decode the message and store it into a string variable
	for (int i = 1; i < rows; i+=step)
	{
		decoded_message = decoded_message + " " + ordered_words[i];
		step = step + 1;
	}
	
	cout << decoded_message;
	MyReadFile.close();
	return decoded_message;
}



void main()
{ 
	//calling the decode function
	decode("coding_qual_input.txt");
}