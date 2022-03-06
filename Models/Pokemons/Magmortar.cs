using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Magmortar Specie to store common natural stats of all Magmortars
	#region SpecieMagmortar
	public class SpecieMagmortar : PokemonSpecie
	{
#nullable enable
		private static SpecieMagmortar? _instance = null;
#nullable restore
        public static SpecieMagmortar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagmortar();
                }
                return _instance;
            }
        }

		#region SpecieMagmortar Builder
		public SpecieMagmortar() : base(
			"Magmortar",
			1.6,
			68.0,
			75, // HPs
			95, 67, // Attack & Defense
			125, 95, // Special Attack & Defense
			83		
		)
		{}
		#endregion
	}
	#endregion

	//Magmortar Pokemon Class
	#region Magmortar
	public class Magmortar : Pokemon
	{
		#region Magmortar Builders
		/// <summary>
		/// Magmortar Builder waiting for a Nickname & a Level
		/// </summary>
		public Magmortar(string nickname, int level)
		: base(
				467,
				SpecieMagmortar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmortar Builder only waiting for a Level
		/// </summary>
		public Magmortar(int level)
		: base(
				467,
				SpecieMagmortar.Instance, // Pokemon Specie
				"Magmortar", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magmortar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Magmortar() : base(
			467,
			SpecieMagmortar.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}