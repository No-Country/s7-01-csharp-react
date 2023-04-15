import React from "react";
import {
  Clock,
  MagnifyingGlass,
  MapPin,
  WhatsappLogo,
} from "@phosphor-icons/react";
import perro from "../../assets/images/perro.png";

const MiniClinic = () => {
  return (
    <div className="container mx-auto md:grid md:grid-cols-2 relative">
      <div className="mt-8 ml-2  w-[394px] h-[149px] flex text-center rounded-xl bg-white ">
        <div className="flex ml-4">
          <div className="w-14 h-14 rounded-full flex mt-2 ">
            <img src={perro} alt="perrito" />
          </div>
          <div className="ml-4 text-center mt-2">
            <p className="font-bold">Nombre de la clínica</p>
            <div className="flex gap-2 ml-2">
              <Clock className="text-gray-100" />
              <p className="text-gray-100 ">LUN A VIE. DE 08:00 a 19:00</p>
            </div>
            <div className="flex gap-2 ml-2">
              <MapPin className="text-gray-100" />
              <p className="text-gray-100">DIRECCIÓN</p>
            </div>
          </div>
        </div>
        <button className="px-4 py-2 absolute bottom-3 left-32 border border-gray-300 rounded-xl ">
          <div className="flex gap-2">
            <WhatsappLogo size={20} className="text-black" />
            <p className="text-black">Whatsapp</p>
          </div>
        </button>
      </div>

    </div>
  );
};

export default MiniClinic;
