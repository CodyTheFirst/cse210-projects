public class Word{
    string _word;

    bool _isHidden = false;

    public Word(string word){
        _word = word;
    }
    public void Display(){
        if (_isHidden == false){
            Console.Write($"{_word} ");
        }
        else if (_isHidden == true){
            foreach (Char i in _word){
                if (Char.IsLetter(i) == true){
                    Console.Write("_");
                }
                else{
                    Console.Write($"{i}");
                }
            }
            Console.Write(" ");
        }
    }

    public void hideWord(){
        
        _isHidden = true;
    }
    
}