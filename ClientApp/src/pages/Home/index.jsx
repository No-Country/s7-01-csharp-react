import { useState } from "react";

const Home = () => {
  return (
    <div class="w-full">      
      <div class="mt-6 p-2">
        <h3 class="text-[16px] font-semibold md:text-center md:font-bold md:text-3xl">Mis Mascotas(5)</h3>
      </div>
      <div class="mt-6 flex w-full justify-around ">        
        <div class="h-20 w-20 rounded-full border-2 bg-slate-200 hover:border-purple-700 hover:scale-125"></div>
        <div class="h-20 w-20 rounded-full border-2 bg-slate-200 hover:border-purple-700 hover:scale-125"></div>
        <div class="h-20 w-20 rounded-full border-2 bg-slate-200 hover:border-purple-700 hover:scale-125"></div>
        <div class="h-20 w-20 rounded-full border-2 bg-slate-200 hover:border-purple-700 hover:scale-125"></div>
      </div>
    </div>
  );
};

export default Home;
