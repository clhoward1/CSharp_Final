namespace C_SharpFinal.Models {

    // Base Student Class
    public class StudentModel {

        private string _name;
        private string _id;

        public StudentModel() {
            Name = "";
            Id = "";
        }

        public StudentModel(string name, string id) {
            Name = name;
            Id = id;
        }

        public string Name { get => _name; set => _name = value; }
        public string Id { get => _id; set => _id = value; }

        // returns name and id in a small format
        // set up for overriding if needed
        public virtual string ReturnBadge() {
            return Name + " - " + Id;
        }
    }
}
