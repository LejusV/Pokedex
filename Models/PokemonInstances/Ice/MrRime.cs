using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mr-Rime PokemonInstance Class
	#region Mr-Rime
	public class MrRime : PokemonInstance
	{
		#region Mr-Rime Constructors
		/// <summary>
		/// Mr-Rime Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MrRime(string nickname, int level)
		: base(
				MrRimeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Rime Constructor only waiting for a Level
		/// </summary>
		public MrRime(int level)
		: this( "Mr-Rime", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Rime Constructor waiting for no params
		/// </summary>
		/*
		public MrRime() : this( "Mr-Rime", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}