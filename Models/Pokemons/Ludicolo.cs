using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ludicolo Specie to store common natural stats of all Ludicolos
	#region SpecieLudicolo
	public class SpecieLudicolo : PokemonSpecie
	{
#nullable enable
		private static SpecieLudicolo? _instance = null;
#nullable restore
        public static SpecieLudicolo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLudicolo();
                }
                return _instance;
            }
        }

		#region SpecieLudicolo Builder
		public SpecieLudicolo() : base(
			"Ludicolo",
			80, // HPs
			70, 70, // Attack & Defense
			90, 100, // Special Attack & Defense
			70		
		)
		{
			this._height = 15;
			this._weight = 550;
		}
		#endregion
	}
	#endregion

	//Ludicolo Pokemon Class
	#region Ludicolo
	public class Ludicolo : Pokemon
	{
		#region Ludicolo Builders
		/// <summary>
		/// Ludicolo Builder waiting for a Nickname & a Level
		/// </summary>
		public Ludicolo(string nickname, int level)
		: base(
				272,
				SpecieLudicolo.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ludicolo Builder only waiting for a Level
		/// </summary>
		public Ludicolo(int level)
		: base(
				272,
				SpecieLudicolo.Instance, // Pokemon Specie
				"Ludicolo", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ludicolo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ludicolo() : base(
			272,
			SpecieLudicolo.Instance, // Pokemon Specie
			Water.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}