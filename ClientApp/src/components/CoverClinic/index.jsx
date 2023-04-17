export function CoverClinic({ logo }) {
  return (
    <>
      <div className="w-full h-48 bg-slate-500 rounded-t-lg border-0">
        <img
          className="w-full h-full object-cover object-center rounded-t-lg border-0"
          src={logo}
          alt="cover clinica"
        />
      </div>

      <div className="w-28 h-28 rounded-full absolute -bottom-14 ml-4 bg-slate-500 border-4 border-black">
        <img
          className="w-full h-full rounded-full object-cover object-center"
          src={logo}
          alt="perfil"
        />
      </div>
    </>
  );
}
