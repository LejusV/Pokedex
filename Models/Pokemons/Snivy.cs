using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Snivy Specie to store common natural stats of all Snivys
	#region SpecieSnivy
	public class SpecieSnivy : PokemonSpecie
	{
#nullable enable
		private static SpecieSnivy? _instance = null;
#nullable restore
        public static SpecieSnivy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnivy();
                }
                return _instance;
            }
        }

		#region SpecieSnivy Builder
		public SpecieSnivy() : base(
			"Snivy",
			0.6,
			8.1,
			45, // HPs
			45, 55, // Attack & Defense
			45, 55, // Special Attack & Defense
			63		
		)
		{}
		#endregion
	}
	#endregion

	//Snivy Pokemon Class
	#region Snivy
	public class Snivy : Pokemon
	{
		#region Snivy Builders
		/// <summary>
		/// Snivy Builder waiting for a Nickname & a Level
		/// </summary>
		public Snivy(string nickname, int level)
		: base(
				495,
				SpecieSnivy.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snivy Builder only waiting for a Level
		/// </summary>
		public Snivy(int level)
		: base(
				495,
				SpecieSnivy.Instance, // Pokemon Specie
				"Snivy", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snivy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Snivy() : base(
			495,
			SpecieSnivy.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}