using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nidorina PokemonInstance Class
	#region Nidorina
	public class Nidorina : PokemonInstance
	{
		#region Nidorina Constructors
		/// <summary>
		/// Nidorina Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nidorina(string nickname, int level)
		: base(
				NidorinaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorina Constructor only waiting for a Level
		/// </summary>
		public Nidorina(int level)
		: this( "Nidorina", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorina Constructor waiting for no params
		/// </summary>
		/*
		public Nidorina() : this( "Nidorina", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}