    public class String
    {
        private string _str = "";
        public string Str
        {
            get
            {
                return _str;
            }
            set
            {
                _str = value;
            }

        }

        public string Concatenate(string str)
        {
        return this.Str + str;
        }
        public string RemoveSubstring(string str)
        {

        if (this.Str.IndexOf(str) != -1)
            {
                return this.Str.Remove(this.Str.IndexOf(str), str.Length);
            }
            else
            {
                return "Другого рядка немає в першому!";
            }
        }
        public string Compare(string str) 
        {
        if (this.Str.Equals(str))
            {
                return "Рядки однакові";
            }
            else
            {
                if (this.Str.Length == str.Length)
                {
                    return "Однакова довжина, але рядки не рівні";
                }
                else if (this.Str.Length > str.Length)
                {
                    return "Перший рядок більший за другий";
                }
                else
                {
                    return "Перший рядок менший за другий";
                }
            }
        }
}