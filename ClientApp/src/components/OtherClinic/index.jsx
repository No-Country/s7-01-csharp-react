// components
<<<<<<< HEAD
=======
import { useEffect, useState } from "react";

>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
import { DataClinic } from "../DataClinic";
import { ContactSocialNetwork } from "../common";

// icons
import { WhatsappLogo } from "@phosphor-icons/react";

<<<<<<< HEAD
export function OtherClinic() {
  return (
    <>
      <div className="p-4 bg-white rounded-lg flex flex-col gap-2">
        <h2 className="text-[#010B1D] not-italic font-medium text-xl">
          Otras clinicas cercanas
        </h2>
        <div className="flex flex-row justify-start gap-4">
          <div className="w-12 h-12 rounded-full bg-slate-500">
            <img
              className="w-full h-full rounded-full object-cover object-center"
              src="https://picsum.photos/200/300?random=1"
              alt="perfil"
            />
          </div>
          <div className="flex flex-col">
            <DataClinic />
            <ContactSocialNetwork
              icon={<WhatsappLogo size={20} />}
              title="Enviar Whatsapp"
            />
          </div>
        </div>
        <hr className="border border-solid border-[#EBEBEB]" />
      </div>
    </>
=======
// rutas
import { Link } from "react-router-dom";

// services
import { getAllClinics } from "../../services/getAllClinics";

// components
import MiniClinic from "../../pages/Home/MiniClinic";

export function OtherClinic({ idNotClinic }) {
  const [clinics, setClinics] = useState([]);

  useEffect(() => {
    getClinics(idNotClinic);
  }, [idNotClinic]);

  const getClinics = async (id) => {
    try {
      const response = await getAllClinics();
      const cli = response.result;
      otherClinics(cli, id);
    } catch (error) {
      console.log(error);
    }
  };

  const otherClinics = (data, id) => {
    const filteredData = data.filter((item) => item.id !== id);
    // console.log(filteredData);
    setClinics(filteredData);
  };

  // console.log(clinics);
  // console.log(idNotClinic);

  if (!clinics || clinics.length == 0) {
    return <div>Cargando...</div>;
  }

  return (
    <div className="p-4 bg-white rounded-lg flex flex-col gap-4">
      <h2 className="text-[#010B1D] not-italic font-medium text-xl">
        Otras clinicas cercanas
      </h2>
      {!clinics || clinics.length == 0 ? (
        <div>Cargando...</div>
      ) : (
        clinics.map((clinic) => (
          <div key={clinic.id}>
            {/* <div className="flex flex-row justify-start gap-6">
              <div className="w-12 h-12 rounded-full bg-slate-500">
                <img
                  className="w-full h-full rounded-full object-cover object-center"
                  src="https://picsum.photos/200/300?random=1"
                  alt="perfil"
                />
              </div>
              <div className="flex flex-col">
                <DataClinic className="text-base" name={clinic.nombre} />
                <ContactSocialNetwork
                  icon={<WhatsappLogo size={20} />}
                  title="Enviar Whatsapp"
                />
              </div>
            </div> */}
            <MiniClinic clinica={clinic} />
            <hr className="mt-4 border border-solid border-[#EBEBEB]" />
          </div>
        ))
      )}
    </div>
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
  );
}
