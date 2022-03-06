using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chikorita Specie to store common natural stats of all Chikoritas
	#region SpecieChikorita
	public class SpecieChikorita : PokemonSpecie
	{
#nullable enable
		private static SpecieChikorita? _instance = null;
#nullable restore
        public static SpecieChikorita Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChikorita();
                }
                return _instance;
            }
        }

		#region SpecieChikorita Builder
		public SpecieChikorita() : base(
			"Chikorita",
			45, // HPs
			49, 65, // Attack & Defense
			49, 65, // Special Attack & Defense
			45		
		)
		{
			this._height = 9;
			this._weight = 64;
		}
		#endregion
	}
	#endregion

	//Chikorita Pokemon Class
	#region Chikorita
	public class Chikorita : Pokemon
	{
		#region Chikorita Builders
		/// <summary>
		/// Chikorita Builder waiting for a Nickname & a Level
		/// </summary>
		public Chikorita(string nickname, int level)
		: base(
				152,
				SpecieChikorita.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chikorita Builder only waiting for a Level
		/// </summary>
		public Chikorita(int level)
		: base(
				152,
				SpecieChikorita.Instance, // Pokemon Specie
				"Chikorita", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chikorita Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chikorita() : base(
			152,
			SpecieChikorita.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}