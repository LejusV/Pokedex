using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Growlithe PokemonInstance Class
	#region Growlithe
	public class Growlithe : PokemonInstance
	{
		#region Growlithe Constructors
		/// <summary>
		/// Growlithe Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Growlithe(string nickname, int level)
		: base(
				GrowlitheSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Growlithe Constructor only waiting for a Level
		/// </summary>
		public Growlithe(int level)
		: this( "Growlithe", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Growlithe Constructor waiting for no params
		/// </summary>
		/*
		public Growlithe() : this( "Growlithe", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}