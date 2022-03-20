using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Girafarig Species to store common natural stats of all Girafarigs
	#region GirafarigSpecies
	public class GirafarigSpecies : PokemonSpecies
	{
#nullable enable
		private static GirafarigSpecies? _instance = null;
#nullable restore
        public static GirafarigSpecies Instance => _instance ?? (_instance = new GirafarigSpecies());

		#region GirafarigSpecies Constructor
		public GirafarigSpecies() : base(
			203,
			"Girafarig",
			Normal.Instance, Psychic.Instance,
			1.5,
			41.5,
			new PokemonStats(
				70, // HPs
				80, 65, // Attack & Defense
				90, 65, // Spacial Attack & Defense
				85 // Speed
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
				"Razor-Wind",
				"Stomp",
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Psybeam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Foresight",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Mirror-Coat",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Facade",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Odor-Sleuth",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Assurance",
				"Power-Swap",
				"Guard-Swap",
				"Sucker-Punch",
				"Energy-Ball",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Double-Hit",
				"Psyshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam",
				"Psychic-Terrain",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion
}