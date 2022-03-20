using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Naganadel Species to store common natural stats of all Naganadels
	#region NaganadelSpecies
	public class NaganadelSpecies : PokemonSpecies
	{
#nullable enable
		private static NaganadelSpecies? _instance = null;
#nullable restore
        public static NaganadelSpecies Instance => _instance ?? (_instance = new NaganadelSpecies());

		#region NaganadelSpecies Constructor
		public NaganadelSpecies() : base(
			804,
			"Naganadel",
			Poison.Instance, Dragon.Instance,
			3.6,
			150.0,
			new PokemonStats(
				73, // HPs
				73, 73, // Attack & Defense
				127, 73, // Spacial Attack & Defense
				121 // Speed
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
				"Growl",
				"Acid",
				"Flamethrower",
				"Hyper-Beam",
				"Peck",
				"Thunderbolt",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Sludge-Bomb",
				"Charm",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Helping-Hand",
				"Air-Cutter",
				"Aerial-Ace",
				"Dragon-Claw",
				"U-Turn",
				"Poison-Jab",
				"Dark-Pulse",
				"Air-Slash",
				"X-Scissor",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Shadow-Claw",
				"Draco-Meteor",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Acrobatics",
				"Dragon-Tail",
				"Snarl",
				"Fell-Stinger",
				"Confide",
				"Venom-Drench",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}