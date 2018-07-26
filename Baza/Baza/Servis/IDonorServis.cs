
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Servis
{
    public interface IDonorServis
    {
        DonorDTO CreateDonor(DonorDTO donorDTO);
        DonorDTO DeleteDonor(DonorDTO donorDTO);
        bool UpdateDonor(DonorDTO donorDTO);
        List<DonorDTO> ReadAllDonor();
        List<DonorDTO> ReadByFilterDonor(DonorDTO donorDTO);
    }
}
