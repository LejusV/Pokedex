using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ludicolo Specie to store common natural stats of every {'abilities': ['swift-swim', 'rain-dish', 'own-tempo'], 'base_experience': 216, 'height': 15, 'id': 272, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'growl', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'absorb', 'mega-drain', 'solar-beam', 'toxic', 'mimic', 'double-team', 'metronome', 'waterfall', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'focus-punch', 'nature-power', 'brick-break', 'knock-off', 'secret-power', 'dive', 'hyper-voice', 'astonish', 'bullet-seed', 'water-pulse', 'natural-gift', 'fling', 'seed-bomb', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'rock-climb', 'captivate', 'grass-knot', 'hone-claws', 'round', 'echoed-voice', 'scald', 'confide', 'power-up-punch'], 'name': 'ludicolo', 'stats': {'hp': 80, 'attack': 70, 'defense': 70, 'special-attack': 90, 'special-defense': 100, 'speed': 70}, 'types': ['water', 'grass'], 'weight': 550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'humanoid', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'plant'], 'names': {'ja-Hrkt': 'ルンパッパ', 'roomaji': 'Runpappa', 'ko': '로파파', 'zh-Hant': '樂天河童', 'fr': 'Ludicolo', 'de': 'Kappalores', 'es': 'Ludicolo', 'it': 'Ludicolo', 'en': 'Ludicolo', 'ja': 'ルンパッパ', 'zh-Hans': '乐天河童'}, 'genera': {'ja-Hrkt': 'のうてんきポケモン', 'ko': '행복하기포켓몬', 'zh-Hant': '樂天寶可夢', 'fr': 'Pokémon Insouciant', 'de': 'Sorglos', 'es': 'Pokémon Optimista', 'it': 'Pokémon Spensierato', 'en': 'Carefree Pokémon', 'ja': 'のうてんきポケモン', 'zh-Hans': '乐天宝可梦'}}
	public class SpecieLudicolo : PokemonSpecie
	{
#nullable enable
		private static SpecieLudicolo? _instance = null;
#nullable restore
        public static SpecieLudicolo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLudicolo();
                }
                return _instance;
            }
        }

		public SpecieLudicolo() : base(
			"Ludicolo",
			80, // HPs
			70, 70, // Attack & Defense
			90, 100, // Special Attack & Defense
			70			
		) {}
	}


	//Ludicolo Pokemon Class
	public class Ludicolo : Pokemon
	{

		public Ludicolo(string nickname, int level)
		: base(
				272,
				SpecieLudicolo.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ludicolo(int level)
		: base(
				272,
				SpecieLudicolo.Instance, // Pokemon Specie
				"Ludicolo", level,
				Water.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ludicolo() : base(
			272,
			SpecieLudicolo.Instance, // Pokemon Specie
			Water.Instance, Grass.Instance			
		) {}
	}
}