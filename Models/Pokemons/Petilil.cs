using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Petilil Specie to store common natural stats of all Petilils
	#region SpeciePetilil
	public class SpeciePetilil : PokemonSpecie
	{
#nullable enable
		private static SpeciePetilil? _instance = null;
#nullable restore
        public static SpeciePetilil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePetilil();
                }
                return _instance;
            }
        }

		#region SpeciePetilil Builder
		public SpeciePetilil() : base(
			"Petilil",
			0.5,
			6.6,
			45, // HPs
			35, 50, // Attack & Defense
			70, 50, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Petilil Pokemon Class
	#region Petilil
	public class Petilil : Pokemon
	{
		#region Petilil Builders
		/// <summary>
		/// Petilil Builder waiting for a Nickname & a Level
		/// </summary>
		public Petilil(string nickname, int level)
		: base(
				548,
				SpeciePetilil.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Petilil Builder only waiting for a Level
		/// </summary>
		public Petilil(int level)
		: base(
				548,
				SpeciePetilil.Instance, // Pokemon Specie
				"Petilil", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Petilil Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Petilil() : base(
			548,
			SpeciePetilil.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}