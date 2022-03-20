using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ninjask PokemonInstance Class
	#region Ninjask
	public class Ninjask : PokemonInstance
	{
		#region Ninjask Constructors
		/// <summary>
		/// Ninjask Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ninjask(string nickname, int level)
		: base(
				NinjaskSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninjask Constructor only waiting for a Level
		/// </summary>
		public Ninjask(int level)
		: this( "Ninjask", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninjask Constructor waiting for no params
		/// </summary>
		/*
		public Ninjask() : this( "Ninjask", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}