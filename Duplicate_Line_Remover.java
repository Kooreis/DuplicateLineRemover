public class DuplicateLineRemover {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader("input.txt"));
        Set<String> lines = new LinkedHashSet<String>();
        String line;