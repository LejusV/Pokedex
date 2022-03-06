using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tynamo Specie to store common natural stats of all Tynamos
	#region SpecieTynamo
	public class SpecieTynamo : PokemonSpecie
	{
#nullable enable
		private static SpecieTynamo? _instance = null;
#nullable restore
        public static SpecieTynamo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTynamo();
                }
                return _instance;
            }
        }

		#region SpecieTynamo Builder
		public SpecieTynamo() : base(
			"Tynamo",
			35, // HPs
			55, 40, // Attack & Defense
			45, 40, // Special Attack & Defense
			60		
		)
		{
			this._height = 2;
			this._weight = 3;
		}
		#endregion
	}
	#endregion

	//Tynamo Pokemon Class
	#region Tynamo
	public class Tynamo : Pokemon
	{
		#region Tynamo Builders
		/// <summary>
		/// Tynamo Builder waiting for a Nickname & a Level
		/// </summary>
		public Tynamo(string nickname, int level)
		: base(
				602,
				SpecieTynamo.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tynamo Builder only waiting for a Level
		/// </summary>
		public Tynamo(int level)
		: base(
				602,
				SpecieTynamo.Instance, // Pokemon Specie
				"Tynamo", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tynamo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tynamo() : base(
			602,
			SpecieTynamo.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}