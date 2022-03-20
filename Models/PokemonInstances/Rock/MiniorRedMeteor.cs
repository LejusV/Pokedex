using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Minior-Red-Meteor PokemonInstance Class
	#region Minior-Red-Meteor
	public class MiniorRedMeteor : PokemonInstance
	{
		#region Minior-Red-Meteor Constructors
		/// <summary>
		/// Minior-Red-Meteor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MiniorRedMeteor(string nickname, int level)
		: base(
				MiniorRedMeteorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minior-Red-Meteor Constructor only waiting for a Level
		/// </summary>
		public MiniorRedMeteor(int level)
		: this( "Minior-Red-Meteor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Minior-Red-Meteor Constructor waiting for no params
		/// </summary>
		/*
		public MiniorRedMeteor() : this( "Minior-Red-Meteor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}