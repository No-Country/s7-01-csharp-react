export function ContactSocialNetwork({ icon, title, className }) {
  return (
    <button className="border-[1px] border-solid border-[#999CA0] rounded-lg flex justify-center items-center gap-2 p-2 focus:ring active:transform active:translate-y-1 w-[10.43em] h-10">
      {icon}
      <p className="text-black not-italic font-normal text-sm">{title}</p>
    </button>
  );
}
