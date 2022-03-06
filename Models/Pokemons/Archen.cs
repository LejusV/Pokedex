using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Archen Specie to store common natural stats of all Archens
	#region SpecieArchen
	public class SpecieArchen : PokemonSpecie
	{
#nullable enable
		private static SpecieArchen? _instance = null;
#nullable restore
        public static SpecieArchen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArchen();
                }
                return _instance;
            }
        }

		#region SpecieArchen Builder
		public SpecieArchen() : base(
			"Archen",
			55, // HPs
			112, 45, // Attack & Defense
			74, 45, // Special Attack & Defense
			70		
		)
		{
			this._height = 5;
			this._weight = 95;
		}
		#endregion
	}
	#endregion

	//Archen Pokemon Class
	#region Archen
	public class Archen : Pokemon
	{
		#region Archen Builders
		/// <summary>
		/// Archen Builder waiting for a Nickname & a Level
		/// </summary>
		public Archen(string nickname, int level)
		: base(
				566,
				SpecieArchen.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archen Builder only waiting for a Level
		/// </summary>
		public Archen(int level)
		: base(
				566,
				SpecieArchen.Instance, // Pokemon Specie
				"Archen", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archen Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Archen() : base(
			566,
			SpecieArchen.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}