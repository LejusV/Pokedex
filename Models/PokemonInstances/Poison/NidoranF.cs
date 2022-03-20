using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nidoran-F PokemonInstance Class
	#region Nidoran-F
	public class NidoranF : PokemonInstance
	{
		#region Nidoran-F Constructors
		/// <summary>
		/// Nidoran-F Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidoranF(string nickname, int level)
		: base(
				NidoranFSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-F Constructor only waiting for a Level
		/// </summary>
		public NidoranF(int level)
		: this( "Nidoran-F", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-F Constructor waiting for no params
		/// </summary>
		/*
		public NidoranF() : this( "Nidoran-F", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}