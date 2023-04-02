import { Calendar, CalendarBlank } from "@phosphor-icons/react";
import Navbar from "../../components/Layouts/Navbar";

const Home = () => {
  return (
    <>
      <Navbar/>
      <div className="mt-4 p-2">
        <h3 className="ml-2 text-[18px] font-bold">Mis Mascotas(5)</h3>
      </div>
      <div className="mt-6 flex w-full justify-around">
        <div className="">
          <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
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
      <div className="mt-4 h-[113px] rounded  ">
        <div className="ml-2 flex flex-row gap-6">
          <div className="h-16 w-16 rounded-full border bg-slate-300 hover:border-purple-700"></div>
          <div className="">
            <p className="text-center">{"Nombre de mascota"}</p>
            <p className="mt-2 text-center">{"Nombre del recordatorio"}</p>
          </div>
          <div className="ml-4">
            <input type="checkbox" className="h-4 w-4 rounded  border-gray-300 bg-gray-100 text-blue-600 focus:ring-2 focus:ring-blue-500 dark:border-gray-600 dark:bg-gray-700 dark:ring-offset-gray-800 dark:focus:ring-blue-600" />
          </div>
        </div>
        <div className="mt-4 flex gap-4 border-t-2 p-2 md:justify-center md:flex">
          <CalendarBlank size={25}/>
          <p className="text-gray-500">Miercoles 18 de abril</p>
        </div>
      </div></>
  );
};

export default Home;
