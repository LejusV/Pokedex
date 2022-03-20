using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Liepard PokemonInstance Class
	#region Liepard
	public class Liepard : PokemonInstance
	{
		#region Liepard Constructors
		/// <summary>
		/// Liepard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Liepard(string nickname, int level)
		: base(
				LiepardSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Liepard Constructor only waiting for a Level
		/// </summary>
		public Liepard(int level)
		: this( "Liepard", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Liepard Constructor waiting for no params
		/// </summary>
		/*
		public Liepard() : this( "Liepard", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}