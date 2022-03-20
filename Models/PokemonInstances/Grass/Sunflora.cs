using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sunflora PokemonInstance Class
	#region Sunflora
	public class Sunflora : PokemonInstance
	{
		#region Sunflora Constructors
		/// <summary>
		/// Sunflora Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sunflora(string nickname, int level)
		: base(
				SunfloraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunflora Constructor only waiting for a Level
		/// </summary>
		public Sunflora(int level)
		: this( "Sunflora", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunflora Constructor waiting for no params
		/// </summary>
		/*
		public Sunflora() : this( "Sunflora", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}