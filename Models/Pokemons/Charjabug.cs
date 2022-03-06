using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Charjabug Specie to store common natural stats of all Charjabugs
	#region SpecieCharjabug
	public class SpecieCharjabug : PokemonSpecie
	{
#nullable enable
		private static SpecieCharjabug? _instance = null;
#nullable restore
        public static SpecieCharjabug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharjabug();
                }
                return _instance;
            }
        }

		#region SpecieCharjabug Builder
		public SpecieCharjabug() : base(
			"Charjabug",
			57, // HPs
			82, 95, // Attack & Defense
			55, 75, // Special Attack & Defense
			36		
		)
		{
			this._height = 5;
			this._weight = 105;
		}
		#endregion
	}
	#endregion

	//Charjabug Pokemon Class
	#region Charjabug
	public class Charjabug : Pokemon
	{
		#region Charjabug Builders
		/// <summary>
		/// Charjabug Builder waiting for a Nickname & a Level
		/// </summary>
		public Charjabug(string nickname, int level)
		: base(
				737,
				SpecieCharjabug.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charjabug Builder only waiting for a Level
		/// </summary>
		public Charjabug(int level)
		: base(
				737,
				SpecieCharjabug.Instance, // Pokemon Specie
				"Charjabug", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charjabug Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Charjabug() : base(
			737,
			SpecieCharjabug.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}