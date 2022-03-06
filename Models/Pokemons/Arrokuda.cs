using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Arrokuda Specie to store common natural stats of all Arrokudas
	#region SpecieArrokuda
	public class SpecieArrokuda : PokemonSpecie
	{
#nullable enable
		private static SpecieArrokuda? _instance = null;
#nullable restore
        public static SpecieArrokuda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArrokuda();
                }
                return _instance;
            }
        }

		#region SpecieArrokuda Builder
		public SpecieArrokuda() : base(
			"Arrokuda",
			0.5,
			1.0,
			41, // HPs
			63, 40, // Attack & Defense
			40, 30, // Special Attack & Defense
			66		
		)
		{}
		#endregion
	}
	#endregion

	//Arrokuda Pokemon Class
	#region Arrokuda
	public class Arrokuda : Pokemon
	{
		#region Arrokuda Builders
		/// <summary>
		/// Arrokuda Builder waiting for a Nickname & a Level
		/// </summary>
		public Arrokuda(string nickname, int level)
		: base(
				846,
				SpecieArrokuda.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arrokuda Builder only waiting for a Level
		/// </summary>
		public Arrokuda(int level)
		: base(
				846,
				SpecieArrokuda.Instance, // Pokemon Specie
				"Arrokuda", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arrokuda Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Arrokuda() : base(
			846,
			SpecieArrokuda.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}