using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Larvitar Specie to store common natural stats of all Larvitars
	#region SpecieLarvitar
	public class SpecieLarvitar : PokemonSpecie
	{
#nullable enable
		private static SpecieLarvitar? _instance = null;
#nullable restore
        public static SpecieLarvitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLarvitar();
                }
                return _instance;
            }
        }

		#region SpecieLarvitar Builder
		public SpecieLarvitar() : base(
			"Larvitar",
			0.6,
			72.0,
			50, // HPs
			64, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			41		
		)
		{}
		#endregion
	}
	#endregion

	//Larvitar Pokemon Class
	#region Larvitar
	public class Larvitar : Pokemon
	{
		#region Larvitar Builders
		/// <summary>
		/// Larvitar Builder waiting for a Nickname & a Level
		/// </summary>
		public Larvitar(string nickname, int level)
		: base(
				246,
				SpecieLarvitar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvitar Builder only waiting for a Level
		/// </summary>
		public Larvitar(int level)
		: base(
				246,
				SpecieLarvitar.Instance, // Pokemon Specie
				"Larvitar", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvitar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Larvitar() : base(
			246,
			SpecieLarvitar.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}