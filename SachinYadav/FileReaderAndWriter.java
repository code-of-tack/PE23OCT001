package Exercise4;

import java.io.*;

/*
 * This is exercise 4 of best coding practice by project earlybird.
 * @Author - Sachin Yadav
 * @Organization - Veersa Technologies
 */
public class FileReaderAndWriter {
    public static void main(String[] args) {
        String inputFileName = "C:\\Users\\KIIT\\FileReaderAndWriter\\input.txt";
        String outputFileName = "C:\\Users\\KIIT\\FileReaderAndWriter\\output.txt";
        fileReaderWriter(inputFileName, outputFileName);
    }

    /*
     * Function to read from the file and do some processing and write to output file.
     * @params - {String} - path of the input file
     * @params - {String} - path of the output file
     * @returns - void (no return type )
     */
    private static void fileReaderWriter(String inputFileName, String outputFileName) {
        try {
            BufferedReader reader = new BufferedReader(new FileReader(inputFileName));
            BufferedWriter writer = new BufferedWriter(new FileWriter(outputFileName));
            String line;
            while ((line = reader.readLine()) != null) {
                //convert the line to uppercase.
                String lineToWrite = line.toUpperCase();
                writer.write(lineToWrite);
                writer.newLine(); // Add a newline character for each line.
            }
            reader.close();
            writer.close();
            System.out.println("Data has been processed and written to " + outputFileName);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}


