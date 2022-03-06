using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Beartic Specie to store common natural stats of all Beartics
	#region SpecieBeartic
	public class SpecieBeartic : PokemonSpecie
	{
#nullable enable
		private static SpecieBeartic? _instance = null;
#nullable restore
        public static SpecieBeartic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeartic();
                }
                return _instance;
            }
        }

		#region SpecieBeartic Builder
		public SpecieBeartic() : base(
			"Beartic",
			2.6,
			260.0,
			95, // HPs
			130, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Beartic Pokemon Class
	#region Beartic
	public class Beartic : Pokemon
	{
		#region Beartic Builders
		/// <summary>
		/// Beartic Builder waiting for a Nickname & a Level
		/// </summary>
		public Beartic(string nickname, int level)
		: base(
				614,
				SpecieBeartic.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beartic Builder only waiting for a Level
		/// </summary>
		public Beartic(int level)
		: base(
				614,
				SpecieBeartic.Instance, // Pokemon Specie
				"Beartic", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beartic Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Beartic() : base(
			614,
			SpecieBeartic.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}