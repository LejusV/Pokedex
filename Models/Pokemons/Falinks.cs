using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Falinks Specie to store common natural stats of all Falinkss
	#region SpecieFalinks
	public class SpecieFalinks : PokemonSpecie
	{
#nullable enable
		private static SpecieFalinks? _instance = null;
#nullable restore
        public static SpecieFalinks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFalinks();
                }
                return _instance;
            }
        }

		#region SpecieFalinks Builder
		public SpecieFalinks() : base(
			"Falinks",
			3.0,
			62.0,
			65, // HPs
			100, 100, // Attack & Defense
			70, 60, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Falinks Pokemon Class
	#region Falinks
	public class Falinks : Pokemon
	{
		#region Falinks Builders
		/// <summary>
		/// Falinks Builder waiting for a Nickname & a Level
		/// </summary>
		public Falinks(string nickname, int level)
		: base(
				870,
				SpecieFalinks.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Falinks Builder only waiting for a Level
		/// </summary>
		public Falinks(int level)
		: base(
				870,
				SpecieFalinks.Instance, // Pokemon Specie
				"Falinks", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Falinks Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Falinks() : base(
			870,
			SpecieFalinks.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}