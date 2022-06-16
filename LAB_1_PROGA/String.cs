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

        public string concatenate(string str1, string str2)
        {
            return str1 + str2;
        }
        public string removeSubstring(string str1, string str2)
        {
            if (str1.IndexOf(str2) != -1)
            {
                return str1.Remove(str1.IndexOf(str2), str2.Length);
            }
            else
            {
                return "Другого рядка немає в першому!";
            }
        }
        public string compare(string str1, string str2)
        {
            if (str1.Equals(str2))
            {
                return "Рядки однакові";
            }
            else
            {
                if (str1.Length == str2.Length)
                {
                    return "Однакова довжина, але рядки не рівні";
                }
                else if (str1.Length > str2.Length)
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