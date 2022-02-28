using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Regidrago Specie to store common natural stats of all Regidragos
	#region SpecieRegidrago
	public class SpecieRegidrago : PokemonSpecie
	{
#nullable enable
		private static SpecieRegidrago? _instance = null;
#nullable restore
        public static SpecieRegidrago Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegidrago();
                }
                return _instance;
            }
        }

		#region SpecieRegidrago Builder
		public SpecieRegidrago() : base(
			"Regidrago",
			200, // HPs
			100, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Regidrago Pokemon Class
	#region Regidrago
	public class Regidrago : Pokemon
	{
		#region Regidrago Builders
		/// <summary>
		/// Regidrago Builder waiting for a Nickname & a Level
		/// </summary>
		public Regidrago(string nickname, int level)
		: base(
				895,
				SpecieRegidrago.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regidrago Builder only waiting for a Level
		/// </summary>
		public Regidrago(int level)
		: base(
				895,
				SpecieRegidrago.Instance, // Pokemon Specie
				"Regidrago", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regidrago Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Regidrago() : base(
			895,
			SpecieRegidrago.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}