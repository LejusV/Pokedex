using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Arcanine Species to store common natural stats of all Arcanines
	#region ArcanineSpecies
	public class ArcanineSpecies : PokemonSpecies
	{
#nullable enable
		private static ArcanineSpecies? _instance = null;
#nullable restore
        public static ArcanineSpecies Instance => _instance ?? (_instance = new ArcanineSpecies());

		#region ArcanineSpecies Constructor
		public ArcanineSpecies() : base(
			59,
			"Arcanine",
			Fire.Instance,
			1.9,
			155.0,
			new PokemonStats(
				90, // HPs
				110, 80, // Attack & Defense
				100, 80, // Spacial Attack & Defense
				95 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Dragon-Rage",
				"Dig",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Extreme-Speed",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Overheat",
				"Odor-Sleuth",
				"Aerial-Ace",
				"Covet",
				"Natural-Gift",
				"Dragon-Pulse",
				"Giga-Impact",
				"Thunder-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Iron-Head",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Wild-Charge",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}