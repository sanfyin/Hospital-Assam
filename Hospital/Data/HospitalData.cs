namespace Hospital.Data
{
    public static class HospitalData
    {

        public static List<Department> Departments
        {
            get
            {
                return new List<Department>()
                {
					new Department("Accident and Emergency ","The Accident and Emergency (A&E) department is open 24 hours a day, 7 days a week, to provide immediate care for patients with life-threatening or serious conditions. Our team of highly trained doctors, nurses, and paramedics are ready to handle any medical emergency, from heart attacks and strokes to trauma and poisoning. We have access to advanced equipment and facilities, such as resuscitation rooms, intensive care units, operating theatres, and radiology services. We also work closely with other departments and specialists in the hospital to ensure the best possible outcome for our patients.","ae.jpg"),
                    new Department("Anaesthesia & Critical Care ","The Anaesthesia & Critical Care department provides high-quality and safe care for patients who need anaesthesia for surgery or other procedures, as well as for patients who are critically ill or injured and require intensive care. Our team of expert anaesthesiologists, intensivists, nurses, and technicians are trained and experienced in using the latest techniques and equipment to ensure the best possible outcomes for our patients.","acc.jpg"),
                    new Department("Cardiology ","The Cardiology department provides comprehensive and compassionate care for patients with heart and vascular diseases. Our team of expert cardiologists, nurses, and technicians are trained and experienced in using the latest techniques and equipment to ensure the best possible outcomes for our patients.","c.jpg"),
                    new Department("ENT and Facio Maxillary Surgery ","","entfms.jpg"),
                    new Department("General and Laparoscopic Surgery ","","gls.jpg"),
                    new Department("Internal Medicine ","","im.jpg"),
                    new Department("Neurosurgery ","","n.jpg"),
                    new Department("Obstetrics and Gynaecotogy ","","og.jpg"),
                    new Department("Orthopedics ","","o.jpg"),
                    new Department("Pediatrics and Neonatology ","","pn.jpg"),
                    new Department("Pain and Palliative Care ","","ppc.jpg"),
                    new Department("Diabetes Clinic ","","dc.jpg"),
                    new Department("Urology ","","u.jpg"),
                    new Department("Nephrology ","","n.jpg"),
                    new Department("Surgical Gastroenterology ","","sg.jpg"),
                    new Department("Dermatology ","","d.jpg"),
                    new Department("Gastroenterology ","","g.jpg"),
                    new Department("Oncology ","","o.jpg"),
                    new Department("Psychiatry ","","p.jpg"),


				};
            }
        }

        public static List<Doctor> Doctors
        {
            get
            {
                return new List<Doctor>()
                {
                    new Doctor("Dr Partha Pratim Kalita","MD Medicine","Senior Consultant","Medicine and Diabetology"),
                    new Doctor("Dr Safikul Haque","MS, FIAGES","Senior Consultant General & Laparoscopic Surgery","Surgery"),
                    new Doctor("Dr Baser Ali","MS"," Senior Consultant General & Laparoscopic Surgery","Surgery"),
                    new Doctor("Dr Arpana Das","MS","Consultant Gynaecology & Obstetrics","Gynaecology & Obstetrics"),
                    new Doctor("Dr Saurabh Patowary","MS Orthopaedic","Consultant Orthopaedic Surgeon","Orthopaedic and Spine Surgery"),
                    new Doctor("Dr Surajit Hazarika","MS,  Mch Urology","Consultant Urologist","Urology & Kidney Diseases"),
                    new Doctor("Dr Mrinmoy Deka","MS ENT","Consultant ENT surgeon and Laryngologist","ENT & Faciomaxilary"),
                    new Doctor("Dr Aniruddha Deuri","MD Anaesthesiology and critical care","Senior Consultant Anaesthesiology & Pain Medicine","Pain and palliative care"),
					new Doctor("Dr Hridoy Kumar Das","MD","Consultant Critical care Medicine","Anaesthesia and Critical care")

				};
            }
        }

        public static List<Facility> Facilities
        {
            get
            {
                return new List<Facility>()
                {
					new Facility("CT scan ","","operation-theater"),
                    new Facility("Ultrasound ","","surgeon-alt"),
                    new Facility("Endoscopy ","","surgeon-alt"),
                    new Facility("24x7 Accident and Emergency Services ","","ambulance-cross"),
                    new Facility("Laboratory ","","laboratory"),
                    new Facility("x-Ray ","","xray"),
				};
            }
        }

    }

    public class Doctor
    {
        public string Name { get; set; }

        public string Qualification { get; set; }

        public string Designation { get; set; }

        public string Department { get; set; }

        public Doctor(string name, string qualification, string designation, string department)
        {
            Name = name;
            Qualification = qualification;
            Designation = designation;
            Department = department;
        }


    }

    public class Department
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public Department(string name, string description, string image)
        {
            Name = name;
            Description = description;
            Image = image;
        }
    }

	public class Facility
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public string Icon { get; set; }

		public Facility(string name, string description, string icon)
		{
			Name = name;
			Description = description;
			Icon = icon;
		}
	}
}
