using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gligar Specie to store common natural stats of all Gligars
	#region SpecieGligar
	public class SpecieGligar : PokemonSpecie
	{
#nullable enable
		private static SpecieGligar? _instance = null;
#nullable restore
        public static SpecieGligar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGligar();
                }
                return _instance;
            }
        }

		#region SpecieGligar Builder
		public SpecieGligar() : base(
			"Gligar",
			65, // HPs
			75, 105, // Attack & Defense
			35, 65, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Gligar Pokemon Class
	#region Gligar
	public class Gligar : Pokemon
	{
		#region Gligar Builders
		/// <summary>
		/// Gligar Builder waiting for a Nickname & a Level
		/// </summary>
		public Gligar(string nickname, int level)
		: base(
				207,
				SpecieGligar.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gligar Builder only waiting for a Level
		/// </summary>
		public Gligar(int level)
		: base(
				207,
				SpecieGligar.Instance, // Pokemon Specie
				"Gligar", level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gligar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Gligar() : base(
			207,
			SpecieGligar.Instance, // Pokemon Specie
			Ground.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}