using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kommo-O PokemonInstance Class
	#region Kommo-O
	public class KommoO : PokemonInstance
	{
		#region Kommo-O Constructors
		/// <summary>
		/// Kommo-O Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KommoO(string nickname, int level)
		: base(
				KommoOSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kommo-O Constructor only waiting for a Level
		/// </summary>
		public KommoO(int level)
		: this( "Kommo-O", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kommo-O Constructor waiting for no params
		/// </summary>
		/*
		public KommoO() : this( "Kommo-O", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}