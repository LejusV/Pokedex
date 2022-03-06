using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Litten Specie to store common natural stats of all Littens
	#region SpecieLitten
	public class SpecieLitten : PokemonSpecie
	{
#nullable enable
		private static SpecieLitten? _instance = null;
#nullable restore
        public static SpecieLitten Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLitten();
                }
                return _instance;
            }
        }

		#region SpecieLitten Builder
		public SpecieLitten() : base(
			"Litten",
			45, // HPs
			65, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			70		
		)
		{
			this._height = 4;
			this._weight = 43;
		}
		#endregion
	}
	#endregion

	//Litten Pokemon Class
	#region Litten
	public class Litten : Pokemon
	{
		#region Litten Builders
		/// <summary>
		/// Litten Builder waiting for a Nickname & a Level
		/// </summary>
		public Litten(string nickname, int level)
		: base(
				725,
				SpecieLitten.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litten Builder only waiting for a Level
		/// </summary>
		public Litten(int level)
		: base(
				725,
				SpecieLitten.Instance, // Pokemon Specie
				"Litten", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litten Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Litten() : base(
			725,
			SpecieLitten.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}