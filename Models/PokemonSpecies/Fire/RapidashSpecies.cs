using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rapidash Species to store common natural stats of all Rapidashs
	#region RapidashSpecies
	public class RapidashSpecies : PokemonSpecies
	{
#nullable enable
		private static RapidashSpecies? _instance = null;
#nullable restore
        public static RapidashSpecies Instance => _instance ?? (_instance = new RapidashSpecies());

		#region RapidashSpecies Constructor
		public RapidashSpecies() : base(
			78,
			"Rapidash",
			Fire.Instance,
			1.7,
			95.0,
			new PokemonStats(
				65, // HPs
				100, 70, // Attack & Defense
				80, 80, // Spacial Attack & Defense
				105 // Speed
			)			
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
				"Stomp",
				"Headbutt",
				"Fury-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Bounce",
				"Natural-Gift",
				"Flare-Blitz",
				"Poison-Jab",
				"Giga-Impact",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Inferno",
				"Wild-Charge",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}