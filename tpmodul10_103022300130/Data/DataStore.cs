using tpModul10_103022300130.Model;
using System.Collections.Generic;

namespace tpModul10_103022300130.Data
{
    public static class DataStore
    {
        public static List<Mahasiswa> MahasiswaList { get; } = new List<Mahasiswa>
        {
            new Mahasiswa("Rakha fatih athallah", "103022300130"),
            new Mahasiswa("Ibnu Syawal Alifiean",  "103022300131"),
            new Mahasiswa("Muhammad Arzu Kirana Brutu", "103022300132"),
            new Mahasiswa("Muhammad Bintang",  "103022300133"),
        };
    }
}