using System.Collections.Generic;

namespace ConsoleApp1.PeriodicTable
{

    public class PeriodicTable
    {

        protected Dictionary<string, int> NameDictionary = new Dictionary<string, int>();
        protected Dictionary<string, int> SymbolDictionary = new Dictionary<string, int>();
        protected Dictionary<int, Element> NumberDictionary = new Dictionary<int, Element>();

        public PeriodicTable()
        {
            AddElement(new Element(1, "H", "Hydrogen", 1.007825));
            AddElement(new Element(2, "He", "Helium", 4.00260));
            AddElement(new Element(3, "Li", "Lithium", 6.941));
            AddElement(new Element(4, "Be", "Beryllium", 9.01218));
            AddElement(new Element(5, "B", "Boron", 10.81));
            AddElement(new Element(6, "C", "Carbon", 12.011));
            AddElement(new Element(7, "N", "Nitrogen", 14.0067));
            AddElement(new Element(8, "O", "Oxygen", 15.999));
            AddElement(new Element(9, "F", "Fluorine", 18.99840));
            AddElement(new Element(10, "Ne", "Neon", 20.179));
            AddElement(new Element(11, "Na", "Sodium", 22.98977));
            AddElement(new Element(12, "Mg", "Magnesium", 24.305));
            AddElement(new Element(13, "Al", "Aluminum", 26.98154));
            AddElement(new Element(14, "Si", "Silicon", 28.0855));
            AddElement(new Element(15, "P", "Phosphorus", 0.0));
            AddElement(new Element(16, "S", "Sulphur", 32.06));
            AddElement(new Element(17, "Cl", "Chlorine", 35.453));
            AddElement(new Element(18, "Ar", "Argon", 39.948));
            AddElement(new Element(19, "K", "Potassium", 39.0983));
            AddElement(new Element(20, "Ca", "Calcium", 40.08));
            AddElement(new Element(21, "Sc", "Scandium", 44.9559));
            AddElement(new Element(22, "Ti", "Titanium", 47.90));
            AddElement(new Element(23, "V", "Vanadium", 50.9414));
            AddElement(new Element(24, "Cr", "Chromium", 51.996));
            AddElement(new Element(25, "Mn", "Manganese", 54.9380));
            AddElement(new Element(26, "Fe", "Iron", 55.85));
            AddElement(new Element(27, "Co", "Cobalt", 58.9332));
            AddElement(new Element(28, "Ni", "Nickel", 58.71));
            AddElement(new Element(29, "Cu", "Copper", 63.546));
            AddElement(new Element(30, "Zn", "Zinc", 65.37));
            AddElement(new Element(31, "Ga", "Gallium", 69.72));
            AddElement(new Element(32, "Ge", "Germanium", 72.59));
            AddElement(new Element(33, "As", "Arsenic", 74.9216));
            AddElement(new Element(34, "Se", "Selenium", 78.96));
            AddElement(new Element(35, "Br", "Bromine", 79.904));
            AddElement(new Element(36, "Kr", "Krypton", 83.80));
            AddElement(new Element(37, "Rb", "Rubidium", 85.4678));
            AddElement(new Element(38, "Sr", "Strontium", 87.62));
            AddElement(new Element(39, "Y", "Yttrium", 88.9059));
            AddElement(new Element(40, "Zr", "Zirconium", 91.22));
            AddElement(new Element(41, "Nb", "Niobium", 92.91));
            AddElement(new Element(42, "Mo", "Molybdenum", 95.94));
            AddElement(new Element(43, "Tc", "Technetium", 99.0));
            AddElement(new Element(44, "Ru", "Ruthenium", 101.1));
            AddElement(new Element(45, "Rh", "Rhodium", 102.91));
            AddElement(new Element(46, "Pd", "Palladium", 106.42));
            AddElement(new Element(47, "Ag", "Silver", 107.87));
            AddElement(new Element(48, "Cd", "Cadmium", 112.4));
            AddElement(new Element(49, "In", "Indium", 114.82));
            AddElement(new Element(50, "Sn", "Tin", 118.69));
            AddElement(new Element(51, "Sb", "Antimony", 121.75));
            AddElement(new Element(52, "Te", "Tellurium", 127.6));
            AddElement(new Element(53, "I", "Iodine", 126.9045));
            AddElement(new Element(54, "Xe", "Xenon", 131.29));
            AddElement(new Element(55, "Cs", "Cesium", 132.9054));
            AddElement(new Element(56, "Ba", "Barium", 137.33));
            AddElement(new Element(57, "La", "Lanthanum", 138.91));
            AddElement(new Element(58, "Ce", "Cerium", 140.12));
            AddElement(new Element(59, "Pr", "Praseodymium", 140.91));
            AddElement(new Element(60, "Nd", "Neodymium", 0.0));
            AddElement(new Element(61, "Pm", "Promethium", 147.0));
            AddElement(new Element(62, "Sm", "Samarium", 150.35));
            AddElement(new Element(63, "Eu", "Europium", 167.26));
            AddElement(new Element(64, "Gd", "Gadolinium", 157.25));
            AddElement(new Element(65, "Tb", "Terbium", 158.925));
            AddElement(new Element(66, "Dy", "Dysprosium", 162.50));
            AddElement(new Element(67, "Ho", "Holmium", 164.9));
            AddElement(new Element(68, "Er", "Erbium", 167.26));
            AddElement(new Element(69, "Tm", "Thulium", 168.93));
            AddElement(new Element(70, "Yb", "Ytterbium", 173.04));
            AddElement(new Element(71, "Lu", "Lutetium", 174.97));
            AddElement(new Element(72, "Hf", "Hafnium", 178.49));
            AddElement(new Element(73, "Ta", "Tantalum", 180.95));
            AddElement(new Element(74, "W", "Tungsten", 183.85));
            AddElement(new Element(75, "Re", "Rhenium", 186.23));
            AddElement(new Element(76, "Os", "Osmium", 190.2));
            AddElement(new Element(77, "Ir", "Iridium", 192.2));
            AddElement(new Element(78, "Pt", "Platinum", 195.09));
            AddElement(new Element(79, "Au", "Gold", 196.9655));
            AddElement(new Element(80, "Hg", "Mercury", 200.59));
            AddElement(new Element(81, "Tl", "Thallium", 204.383));
            AddElement(new Element(82, "Pb", "Lead", 207.2));
            AddElement(new Element(83, "Bi", "Bismuth", 208.9804));
            AddElement(new Element(84, "Po", "Polonium", 210.0));
            AddElement(new Element(85, "At", "Astatine", 210.0));
            AddElement(new Element(86, "Rn", "Radon", 222.0));
            AddElement(new Element(87, "Fr", "Francium", 233.0));
            AddElement(new Element(88, "Ra", "Radium", 226.0254));
            AddElement(new Element(89, "Ac", "Actinium", 227.0));
            AddElement(new Element(90, "Th", "Thorium", 232.04));
            AddElement(new Element(91, "Pa", "Protactinium", 231.0359));
            AddElement(new Element(92, "U", "Uranium", 238.03));
            AddElement(new Element(93, "Np", "Neptunium", 237.0));
            AddElement(new Element(94, "Pu", "Plutonium", 244.0));
            AddElement(new Element(95, "Am", "Americium", 243.0));
            AddElement(new Element(96, "Cm", "Curium", 247.0));
            AddElement(new Element(97, "Bk", "Berkelium", 247.0));
            AddElement(new Element(98, "Cf", "Californium", 251.0));
            AddElement(new Element(99, "Es", "Einsteinium", 254.0));
            AddElement(new Element(100, "Fm", "Fermium", 257.0));
            AddElement(new Element(101, "Md", "Mendelevium", 258.0));
            AddElement(new Element(102, "No", "Nobelium", 259.0));
            AddElement(new Element(103, "Lr", "Lawrencium", 262.0));
            AddElement(new Element(104, "Rf", "Rutherfordium", 260.9));
            AddElement(new Element(105, "Db", "Dubnium", 261.9));
            AddElement(new Element(106, "Sg", "Seaborgium", 262.94));
            AddElement(new Element(107, "Bh", "Bohrium", 262.0));
            AddElement(new Element(108, "Hs", "Hassium", 264.8));
            AddElement(new Element(109, "Mt", "Meitnerium", 265.9));
            AddElement(new Element(110, "Ds", "Darmstadtium", 261.9));
            AddElement(new Element(112, "Uub", "Ununbium", 276.8));
            AddElement(new Element(114, "Uuq", "Ununquadium", 289.0));
            AddElement(new Element(116, "Uuh", "Ununhexium", 0.0));
        }

        protected void AddElement(Element element)
        {
            NameDictionary.Add(element.Name, element.AtomicNumber);
            SymbolDictionary.Add(element.Symbol, element.AtomicNumber);
            NumberDictionary.Add(element.AtomicNumber, element);
        }

        public Element GetElementByName(string name)
        {
            return NumberDictionary[ NameDictionary[name] ];
        }

        public Element GetElement(string symbol)
        {
            return NumberDictionary[ SymbolDictionary[symbol] ];
        }

        public Element GetElement(int atomicNum)
        {
            return NumberDictionary[atomicNum];
        }

    }
}
