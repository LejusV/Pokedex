using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jangmo-O Species to store common natural stats of all Jangmo-Os
	#region SpeciesJangmo-O
	public class SpeciesJangmoO : PokemonSpecies
	{
#nullable enable
		private static SpeciesJangmoO? _instance = null;
#nullable restore
        public static SpeciesJangmoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJangmoO();
                }
                return _instance;
            }
        }

		#region SpeciesJangmo-O Constructor
		public SpeciesJangmoO() : base(
			"Jangmo-O",
			0.6,
			29.7,
			45, // HPs
			55, 65, // Attack & Defense
			45, 45, // Special Attack & Defense
			45		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Headbutt",
				"Tackle",
				"Leer",
				"Roar",
				"Counter",
				"Earthquake",
				"Toxic",
				"Screech",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Reversal",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Sandstorm",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bulk-Up",
				"Dragon-Dance",
				"Payback",
				"X-Scissor",
				"Focus-Blast",
				"Shadow-Claw",
				"Draco-Meteor",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Noble-Roar",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Jangmo-O PokemonInstance Class
	#region Jangmo-O
	public class JangmoOInstance : PokemonInstance
	{
		#region Jangmo-O Constructors
		/// <summary>
		/// Jangmo-O Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JangmoOInstance(string nickname, int level)
		: base(
				782,
				SpeciesJangmoO.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jangmo-O Builder only waiting for a Level
		/// </summary>
		public JangmoOInstance(int level)
		: base(
				782,
				SpeciesJangmoO.Instance, // PokemonInstance Species
				"Jangmo-O", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jangmo-O Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public JangmoO() : base(
			782,
			SpeciesJangmoO.Instance, // PokemonInstance Species
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}