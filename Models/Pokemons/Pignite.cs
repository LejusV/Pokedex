using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pignite Specie to store common natural stats of all Pignites
	#region SpeciePignite
	public class SpeciePignite : PokemonSpecie
	{
#nullable enable
		private static SpeciePignite? _instance = null;
#nullable restore
        public static SpeciePignite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePignite();
                }
                return _instance;
            }
        }

		#region SpeciePignite Builder
		public SpeciePignite() : base(
			"Pignite",
			1.0,
			55.5,
			90, // HPs
			93, 55, // Attack & Defense
			70, 55, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Pignite Pokemon Class
	#region Pignite
	public class Pignite : Pokemon
	{
		#region Pignite Builders
		/// <summary>
		/// Pignite Builder waiting for a Nickname & a Level
		/// </summary>
		public Pignite(string nickname, int level)
		: base(
				499,
				SpeciePignite.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pignite Builder only waiting for a Level
		/// </summary>
		public Pignite(int level)
		: base(
				499,
				SpeciePignite.Instance, // Pokemon Specie
				"Pignite", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pignite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pignite() : base(
			499,
			SpeciePignite.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}