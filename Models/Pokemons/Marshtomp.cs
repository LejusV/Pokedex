using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Marshtomp Specie to store common natural stats of all Marshtomps
	#region SpecieMarshtomp
	public class SpecieMarshtomp : PokemonSpecie
	{
#nullable enable
		private static SpecieMarshtomp? _instance = null;
#nullable restore
        public static SpecieMarshtomp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarshtomp();
                }
                return _instance;
            }
        }

		#region SpecieMarshtomp Builder
		public SpecieMarshtomp() : base(
			"Marshtomp",
			0.7,
			28.0,
			70, // HPs
			85, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Marshtomp Pokemon Class
	#region Marshtomp
	public class Marshtomp : Pokemon
	{
		#region Marshtomp Builders
		/// <summary>
		/// Marshtomp Builder waiting for a Nickname & a Level
		/// </summary>
		public Marshtomp(string nickname, int level)
		: base(
				259,
				SpecieMarshtomp.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshtomp Builder only waiting for a Level
		/// </summary>
		public Marshtomp(int level)
		: base(
				259,
				SpecieMarshtomp.Instance, // Pokemon Specie
				"Marshtomp", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshtomp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Marshtomp() : base(
			259,
			SpecieMarshtomp.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}