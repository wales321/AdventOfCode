using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class ElfDirectory
    {
        public ElfDirectory(ElfDirectory? parent)
        {
            Directories = new List<ElfDirectory>();
            Files = new List<ElfFile>();
            Parent = parent;
        }

        public ElfDirectory? Parent { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DirectorySize => Files.Sum(x => x.Size) + Directories.Sum(x => x.DirectorySize);
        public List<ElfDirectory> Directories { get; set; }
        public List<ElfFile> Files { get; set; }
    }
}
