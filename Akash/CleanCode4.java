import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FileProcessingExample {

    public static void main(String[] args) {
        String inputFile = "C:\\Users\\KIIT\\input.txt";
        String outputFile = "C:\\Users\\KIIT\\output.txt";

        try {
            BufferedReader reader = new BufferedReader(new FileReader(inputFile));
            BufferedWriter writer = new BufferedWriter(new FileWriter(outputFile));

            String line;
            while ((line = reader.readLine()) != null) {
                writer.write(line);
                writer.newLine();
                System.out.println(line);
            }
            reader.close();
            writer.close();

            System.out.println("Results written!");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
