using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jangmo-O PokemonInstance Class
	#region Jangmo-O
	public class JangmoO : PokemonInstance
	{
		#region Jangmo-O Constructors
		/// <summary>
		/// Jangmo-O Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JangmoO(string nickname, int level)
		: base(
				JangmoOSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jangmo-O Constructor only waiting for a Level
		/// </summary>
		public JangmoO(int level)
		: this( "Jangmo-O", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jangmo-O Constructor waiting for no params
		/// </summary>
		/*
		public JangmoO() : this( "Jangmo-O", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}