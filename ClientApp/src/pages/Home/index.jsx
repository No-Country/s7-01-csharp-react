<<<<<<< HEAD
=======
import { CalendarBlank, MagnifyingGlass, PawPrint, Syringe } from "@phosphor-icons/react";
>>>>>>> 892baca (fixeando tailwind)
import Navbar from "../../components/Layouts/Navbar";
import RememberCards from "./RememberCards";
import ClinicCard from "./ClinicCard";
import ShowPets from "./ShowPets";


const Home = () => {
  return (
    <>
      <Navbar />
<<<<<<< HEAD
      <ShowPets/>
      <RememberCards/>
      <ClinicCard/>
=======
      <div className="mt-4 p-2 bg-gray-50">
        <h3 className="ml-2 text-[18px] font-bold">Mis Mascotas(5)</h3>
      </div>
      <div className="mt-6 flex w-full justify-around">
        <div className="relative">
          <div className="h-16 w-16 rounded-full border bg-gray-100 hover:border-purple-700"><PawPrint size={28} className="absolute left-4 top-4" /></div>
          <p className="text-center">Agregar</p>
          <p className="text-center">Mascota</p>
        </div>
        <div className="">
          <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
          <p className="text-center">{"Mascota"}</p>
        </div>
        <div className="">
          <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
          <p className="text-center">{"Mascota"}</p>
        </div>
        <div className="">
          <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
          <p className="text-center">{"Mascota"}</p>
        </div>
        <div className="">
          <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
          <p className="text-center">{"Mascota"}</p>
        </div>
      </div>
      <div className="mt-5 p-2">
        <h3 className="ml-2 text-[18px] font-bold ">Proximos Recordatorios (3)</h3>
      </div>
      <div className="mt-4 h-[113px] rounded bg-white">
        <div className="ml-2 flex flex-row gap-6 relative">
          <div className="h-16 w-16 rounded-full border bg-gray-50 hover:border-purple-700 "><Syringe size={30} className="left-4 bottom-4  absolute" /></div>
          <div className="">
            <p className="text-center">{"Nombre de mascota"}</p>
            <p className="mt-2 text-center">{"Nombre del recordatorio"}</p>
          </div>
          <div className="ml-4">
            <input type="checkbox" className="h-4 w-4 rounded  border-gray-300 bg-gray-100 text-blue-600 focus:ring-2 focus:ring-blue-500 dark:border-gray-600 dark:bg-gray-700 dark:ring-offset-gray-800 dark:focus:ring-blue-600" />
          </div>
        </div>
        <div className="mt-4 flex gap-4 border-t-2 p-2 md:justify-center md:flex">
          <CalendarBlank size={25} />
          <p className="text-center text-gray-500">Miercoles 18 de abril</p>
        </div>
      </div>
      <div className="mt-4 px-2">
        <h3 className="mt-4">Clinicas Veterinarias</h3>
        <div className="mt-4 w-[328px] h-[40px] rounded-xl  flex items-center gap-2">
          <MagnifyingGlass size={20}/>
          <input type="text" className=" w-[280px] h-[21px]  rounded-md p-4 " placeholder="Buscar Veterinarias" />
        </div>
      </div>
      <div className="mx-auto grid grid-cols-2 gap-4 justify-between mt-4">
        <button className="bg-primary-100 rounded-xl px-2 py-1">
          Cirugía
        </button>
        <button className="bg-primary-100 rounded-xl px-2 py-1">
          Vacunas
        </button>
        <button className="bg-primary-100 rounded-xl px-2 py-1">
          Desparacitacion
        </button>
        <button className="bg-primary-100  rounded-xl px-2 py-1">
          Atención
        </button>
      </div>
>>>>>>> 892baca (fixeando tailwind)
    </>
  );
};

export default Home;
