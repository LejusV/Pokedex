using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dartrix Specie to store common natural stats of all Dartrixs
	#region SpecieDartrix
	public class SpecieDartrix : PokemonSpecie
	{
#nullable enable
		private static SpecieDartrix? _instance = null;
#nullable restore
        public static SpecieDartrix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDartrix();
                }
                return _instance;
            }
        }

		#region SpecieDartrix Builder
		public SpecieDartrix() : base(
			"Dartrix",
			0.7,
			16.0,
			78, // HPs
			75, 75, // Attack & Defense
			70, 70, // Special Attack & Defense
			52		
		)
		{}
		#endregion
	}
	#endregion

	//Dartrix Pokemon Class
	#region Dartrix
	public class Dartrix : Pokemon
	{
		#region Dartrix Builders
		/// <summary>
		/// Dartrix Builder waiting for a Nickname & a Level
		/// </summary>
		public Dartrix(string nickname, int level)
		: base(
				723,
				SpecieDartrix.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dartrix Builder only waiting for a Level
		/// </summary>
		public Dartrix(int level)
		: base(
				723,
				SpecieDartrix.Instance, // Pokemon Specie
				"Dartrix", level,
				Grass.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dartrix Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dartrix() : base(
			723,
			SpecieDartrix.Instance, // Pokemon Specie
			Grass.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}