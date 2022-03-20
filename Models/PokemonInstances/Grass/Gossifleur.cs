using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gossifleur PokemonInstance Class
	#region Gossifleur
	public class Gossifleur : PokemonInstance
	{
		#region Gossifleur Constructors
		/// <summary>
		/// Gossifleur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gossifleur(string nickname, int level)
		: base(
				GossifleurSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gossifleur Constructor only waiting for a Level
		/// </summary>
		public Gossifleur(int level)
		: this( "Gossifleur", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gossifleur Constructor waiting for no params
		/// </summary>
		/*
		public Gossifleur() : this( "Gossifleur", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}