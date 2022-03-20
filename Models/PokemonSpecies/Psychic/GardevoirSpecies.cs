using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gardevoir Species to store common natural stats of all Gardevoirs
	#region GardevoirSpecies
	public class GardevoirSpecies : PokemonSpecies
	{
#nullable enable
		private static GardevoirSpecies? _instance = null;
#nullable restore
        public static GardevoirSpecies Instance => _instance ?? (_instance = new GardevoirSpecies());

		#region GardevoirSpecies Constructor
		public GardevoirSpecies() : base(
			282,
			"Gardevoir",
			Psychic.Instance, Fairy.Instance,
			1.6,
			48.4,
			new PokemonStats(
				68, // HPs
				65, 65, // Attack & Defense
				125, 115, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Ally-Switch",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}