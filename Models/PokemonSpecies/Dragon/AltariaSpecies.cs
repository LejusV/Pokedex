using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Altaria Species to store common natural stats of all Altarias
	#region AltariaSpecies
	public class AltariaSpecies : PokemonSpecies
	{
#nullable enable
		private static AltariaSpecies? _instance = null;
#nullable restore
        public static AltariaSpecies Instance => _instance ?? (_instance = new AltariaSpecies());

		#region AltariaSpecies Constructor
		public AltariaSpecies() : base(
			334,
			"Altaria",
			Dragon.Instance, Flying.Instance,
			1.1,
			20.6,
			new PokemonStats(
				75, // HPs
				70, 90, // Attack & Defense
				70, 105, // Spacial Attack & Defense
				80 // Speed
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
				"Fly",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Sing",
				"Flamethrower",
				"Mist",
				"Ice-Beam",
				"Hyper-Beam",
				"Peck",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Perish-Song",
				"Outrage",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Refresh",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Air-Cutter",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Dragon-Pulse",
				"Giga-Impact",
				"Draco-Meteor",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Wonder-Room",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Bulldoze",
				"Cotton-Guard",
				"Disarming-Voice",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}